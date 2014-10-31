module Danhmuc
  class DmkhosController < PageController
    helper_method :sort_column, :sort_direction
    respond_to :html, :js

    def index
      @dmkhos = Dmkho.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
    end

    def show
      @dmkho = Dmkho.find(params[:id])
    end

    def edit
      @dmkho = Dmkho.find(params[:id])
    end

    def update
      @dmkhos = Dmkho.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)

      @dmkho = Dmkho.find(params[:id])
      @dmkho.update_attributes(dmkho_params)
    end

    def new
      @dmkho = Dmkho.new
    end

    def create
      @dmkhos = Dmkho.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
      @dmkho =Dmkho.create(dmkho_params)
    end

    def delete
      @dmkho = Dmkho.find(params[:dmkho_id])
    end

    def destroy
      @dmkhos = Dmkho.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
      @dmkho = Dmkho.find(params[:id])
      @dmkho.destroy
    end

    private
    def dmkho_params
      params.require(:dmkho).permit(:stt, :ten, :dmloaikho_id)
    end

    def sort_column
      Dmkho.column_names.include?(params[:sort]) ? params[:sort] : "ten"
    end

    def sort_direction
      %w[asc desc].include?(params[:direction]) ? params[:direction] : "asc"
    end
  end
end