# Este script corrige el directorio de la base de datos EjemploPatronesSoftware.db
# en el codigo fuente.
# La ruta se encuentra en "Codigo Duro", para facilitar su lectura.
# ¡¡¡No lo dejes asi en Producción!!!
@database='EjemploPatronesSoftware.db'
@pattern=/(["=])[^"=]+?#{@database}/
@nombre=File.expand_path("./Scripts/Sqlite/#{@database}").gsub(%r{/}) { "\\" }

def find_and_replace(dir)
  Dir[dir + '*/*.{cs,config}'].each do |name|
	puts name
	new_file=''
	File.open(name, 'r+') do |f|
		new_file = f.read.gsub(@pattern) { "#{$1}#{@nombre}" }
	end
	File.open(name, 'w') { |f| f.write(new_file) }
  end
  Dir[dir + '/*/'].each(&method(:find_and_replace))
end

find_and_replace '.'